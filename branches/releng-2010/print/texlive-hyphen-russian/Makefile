# New ports collection makefile for:	texlive-hyphen-russian
# Date created:		13/03/2010 04:35:08
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	hyphen-russian
PORTVERSION=	20100921
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	The hyphen-russian package

RUN_DEPENDS=	${LOCALBASE}/share/texmf/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf-dist/tex/generic/ruhyphen/ruhyphen.tex:${PORTSDIR}/print/texlive-ruhyphen

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
