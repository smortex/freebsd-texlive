# New ports collection makefile for:	texlive-hyphen-ukrainian
# Date created:		26/01/2009 16:05:59
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	hyphen-ukrainian
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	The hyphen-ukrainian package

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/ukrhyph/ukrhyph.tex:${PORTSDIR}/print/texlive-ukrhyph

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
