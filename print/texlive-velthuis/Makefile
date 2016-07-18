# $FreeBSD$

PORTNAME=	velthuis
PORTVERSION=	20160710
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Typeset Devanagari

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/misc/xetex/fontmapping/xetex-devanagari/README:${PORTSDIR}/print/texlive-xetex-devanagari \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
