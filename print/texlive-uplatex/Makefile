# $FreeBSD$

PORTNAME=	uplatex
PORTVERSION=	20160702
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	pLaTeX2e and miscellaneous macros for upTeX

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/uptex/uptex-base/euptex.ini:${PORTSDIR}/print/texlive-uptex-base \
		${LOCALBASE}/share/texmf-dist/fonts/cmap/uptex-fonts/UTF8-UTF16:${PORTSDIR}/print/texlive-uptex-fonts \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
