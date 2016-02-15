# $FreeBSD$

PORTNAME=	luaotfload
PORTVERSION=	20160213
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	OpenType 'loader' for Plain TeX and LaTeX

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
