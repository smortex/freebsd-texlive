# New ports collection makefile for:	texlive-hyphen-russian
# Date created:		26/01/2009 16:05:59
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	hyphen-russian
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	The hyphen-russian package

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/ruhyphen/ruhyphen.tex:${PORTSDIR}/print/texlive-ruhyphen

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
