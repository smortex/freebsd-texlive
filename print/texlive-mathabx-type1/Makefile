# $FreeBSD$

PORTNAME=	mathabx-type1
PORTVERSION=	20150412
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Outline version of the mathabx fonts.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/mathabx/mathabx.sty:${PORTSDIR}/print/texlive-mathabx

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
