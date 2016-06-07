# $FreeBSD$

PORTNAME=	kotex-oblivoir
PORTVERSION=	20160414
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A LaTeX document class for typesetting Korean documents

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/memoir/memoir.cls:${PORTSDIR}/print/texlive-memoir \
		${LOCALBASE}/share/texmf-dist/tex/latex/kotex-utf/contrib/dhucs-cmap.sty:${PORTSDIR}/print/texlive-kotex-utf

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
