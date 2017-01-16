# $FreeBSD$

PORTNAME=	ptex-fontmaps
PORTVERSION=	20170116
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Font maps and configuration tools for Japanese/Chinese/Korean fonts with (u)ptex

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/truetype/public/arphic-ttf/bkai00mp.ttf:${PORTSDIR}/print/texlive-arphic-ttf \
		${LOCALBASE}/share/texmf-dist/fonts/truetype/public/baekmuk/batang.ttf:${PORTSDIR}/print/texlive-baekmuk \
		${LOCALBASE}/share/texmf-dist/fonts/truetype/public/ipaex/ipaexg.ttf:${PORTSDIR}/print/texlive-ipaex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
