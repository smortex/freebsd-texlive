# $FreeBSD$

PORTNAME=	latexpand
PORTVERSION=	20150618
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Expand \input and \include in a LaTeX document.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
